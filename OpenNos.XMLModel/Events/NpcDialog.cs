﻿using System;
using System.Xml.Serialization;

namespace OpenNos.XMLModel.Events
{
    [Serializable]
    public class NpcDialog
    {
        #region Properties

        [XmlAttribute]
        public int Value { get; set; }

        #endregion
    }
}