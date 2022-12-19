using UnityEditor;

public class CreateMirrorScriptHelper
{
    [MenuItem("Assets/Create/Mirror/NetworkManager", priority = 20)]
    public static void CreateNetworkManager()
    {
        string templatePath =  "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/50-Mirror__Network Manager-NewNetworkManager.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkManager.cs");
    }

    [MenuItem("Assets/Create/Mirror/NewNetworkAuthenticator", priority = 20)]
    public static void CreateNetworkAuthenticator()
    {
        string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/51-Mirror__Network Authenticator-NewNetworkAuthenticator.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkAuthenticator.cs");
    }

    [MenuItem("Assets/Create/Mirror/NewNetworkBehaviour", priority = 20)]
    public static void CreateNetworkBehaviour()
    {
        string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/52-Mirror__Network Behaviour-NewNetworkBehaviour.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkBehaviour.cs");
    }

    [MenuItem("Assets/Create/Mirror/NewCustomInterestManagement", priority = 20)]
    public static void CreateCustomInterestManagement()
    {
        string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/53-Mirror__Custom Interest Management-CustomInterestManagement.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewCustomInterestManagement.cs");
    }

    [MenuItem("Assets/Create/Mirror/NewNetworkRoomManager", priority = 20)]
    public static void CreateNetworkRoomManager()
    {
        string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/54-Mirror__Network Room Manager-NewNetworkRoomManager.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkRoomManager.cs");
    }

    [MenuItem("Assets/Create/Mirror/NewNetworkRoomPlayer", priority = 20)]
    public static void CreateNewNetworkRoomPlayer()
    {
        string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/55-Mirror__Network Room Player-NewNetworkRoomPlayer.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkRoomPlayer.cs");
    }

    [MenuItem("Assets/Create/Mirror/NewNetworkDiscovery", priority = 20)]
    public static void CreateNetworkDiscovery()
    {
        string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/56-Mirror__Network Discovery-NewNetworkDiscovery.cs.txt";

        ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkDiscovery.cs");
    }

    //57-Mirror__Network Transform-NewNetworkTransform.cs
    //[MenuItem("Assets/Create/Mirror/NewNetworkTransform", priority = 20)]
    //public static void CreateNetworkTransform()
    //{
    //    string templatePath = "Packages/MirrorPackage/Mirror/Assets/ScriptTemplates/57-Mirror__Network Transform-NewNetworkTransform.cs.txt";

    //    ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, "NewNetworkTransform.cs");
    //}
}
