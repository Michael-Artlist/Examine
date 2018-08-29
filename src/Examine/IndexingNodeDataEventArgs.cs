﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Examine
{
    public class IndexingNodeDataEventArgs : IndexingNodeEventArgs
    {
        public IndexingNodeDataEventArgs(XElement node, int nodeId, Dictionary<string, string> fields, string indexType)
            : base(nodeId, fields, indexType)
        {
            this.Node = node;
        }

        public IndexingNodeDataEventArgs(XElement node, int nodeId, string indexType)
            : base(nodeId, null, indexType)
        {
            this.Node = node;
        }

        public IndexingNodeDataEventArgs(int nodeId, Dictionary<string, string> fields, string indexType)
            : base(nodeId, fields, indexType)
        {
        }

        public XElement Node { get; private set; }
    }
}
