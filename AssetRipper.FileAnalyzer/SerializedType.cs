﻿using AssetRipper.Core.Parser.Files.SerializedFiles.Parser.TypeTree;

namespace AssetRipper.FileAnalyzer
{
	public class SerializedType
	{
		public int classID;
		public bool m_IsStrippedType;
		public short m_ScriptTypeIndex = -1;
		public TypeTree m_Type;
		public byte[] m_ScriptID; //Hash128
		public byte[] m_OldTypeHash; //Hash128
		public int[] m_TypeDependencies;
		public string m_KlassName;
		public string m_NameSpace;
		public string m_AsmName;
	}
}
