using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityToolbarExtender;

[Serializable]
internal class ToolbarJenny : BaseToolbarElement {
	private static GUIContent jennyBtn;

	public override string NameInList => "[Button] Jenny Generate";

	public override void Init() {
		jennyBtn = new GUIContent((Texture2D)AssetDatabase.LoadAssetAtPath($"{GetPackageRootPath}/Editor/CustomToolbar/Icons/Jenny@4x.png", typeof(Texture2D)), "Jennyrate");
	}

	protected override void OnDrawInList(Rect position) {

	}

	protected override void OnDrawInToolbar() {
		if (GUILayout.Button(jennyBtn, ToolbarStyles.commandButtonStyle)) {
			DesperateDevs.CodeGeneration.CodeGenerator.Unity.Editor.UnityCodeGenerator.Generate();
		}
	}
}
