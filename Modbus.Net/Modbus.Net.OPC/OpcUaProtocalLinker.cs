﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus.Net.OPC
{
    /// <summary>
    /// Opc Da协议连接器
    /// </summary>
    public class OpcUaProtocalLinker : OpcProtocalLinker
    {
        public OpcUaProtocalLinker() : this(ConfigurationManager.OpcUaHost)
        {
        }

        public OpcUaProtocalLinker(string host)
        {
            BaseConnector = OpcUaConnector.Instance(host);
        }
    }
}
