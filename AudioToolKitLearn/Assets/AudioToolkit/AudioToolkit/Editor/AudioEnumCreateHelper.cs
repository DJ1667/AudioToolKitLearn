using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

public class AudioEnumCreateHelper : MonoBehaviour
{
    private static string AudioControllerPrefabPath = Application.dataPath + "/AudioToolkit/Prefab";
    private static string AudioEnumSavePath = Application.dataPath + "/AudioToolkit/AudioToolkit";

    private static Dictionary<string, int> _tempDict = new Dictionary<string, int>();

    [MenuItem("Tools/音频/生成音频枚举（仅对Prefab有效）")]
    public static void CreateCodeForAllPrefab()
    {
        _tempDict.Clear();

        string[] prefabPaths = Directory.GetFiles(AudioControllerPrefabPath, "*.prefab");

        StringBuilder classSource = new StringBuilder();
        classSource.AppendLine("/*Auto Create, Don't Edit !!!*/");
        classSource.AppendLine();
        classSource.AppendLine($"public enum AudioName");
        classSource.AppendLine("{");

        foreach (var path in prefabPaths)
        {
            var tempPath = path.Replace(Application.dataPath, "Assets");
            var go = AssetDatabase.LoadAssetAtPath<GameObject>(tempPath);
            var ac = go.GetComponent<AudioController>();
            if (ac == null)
            {
                continue;
            }

            if (ac.AudioCategories == null) continue;

            classSource.AppendLine($"\t#region  {go.name} ---> {(ac.isAdditionalAudioController ? "Additional" : "Main")} ");
            classSource.AppendLine();

            foreach (var category in ac.AudioCategories)
            {
                if (category.AudioItems == null) continue;

                classSource.AppendLine($"\t/*---------- {category.Name}  ----------*/");
                classSource.AppendLine();

                foreach (var item in category.AudioItems)
                {
                    if (_tempDict.ContainsKey(item.Name))
                        classSource.AppendLine($"\t//{item.Name},\t\t//{item.TipsInfo}    注意!!! ==> 该音频重复添加，请修改");
                    else
                    {
                        classSource.AppendLine($"\t{item.Name},\t\t//{item.TipsInfo}");
                        _tempDict.Add(item.Name, 1);
                    }
                }

                classSource.AppendLine();
                classSource.AppendLine($"\t/*------------------------------*/");
                classSource.AppendLine();
            }

            classSource.AppendLine($"\t#endregion");
            classSource.AppendLine();
        }

        classSource.AppendLine("}");

        WriteStringToFile(classSource.ToString(), "AudioName.cs");
    }
    
    private static void WriteStringToFile(string content, string fileName)
    {
        var path = AudioEnumSavePath;
        var fullFilePath = path + "/" + fileName;

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }

        //写入文件
        if (File.Exists(fullFilePath))
        {
            Debug.Log(fullFilePath + "    文件已存在，将被替换");
        }
        else
        {
            Debug.Log(fullFilePath + "    创建文件");
        }

        //补充 using(){} ()中的对象必须继承IDispose接口,在{}结束后会自动释放资源,也就是相当于帮你调用了Dispos()去释放资源
        using (FileStream fileStream = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write))
        {
            using (TextWriter textWriter = new StreamWriter(fileStream, Encoding.UTF8))
            {
                textWriter.Write(content);
            }
        }

        AssetDatabase.Refresh();
    }
}

#endif