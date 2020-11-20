﻿/****************************************************** 
Writer:Du YanMing
Mail:dym880@163.com
Create Date:2020/8/18 18:02:49 
Functional description： ITaskService
******************************************************/
using Anno.EngineData;
using Anno.Rpc.Client.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anno.Test
{
    [AnnoProxy(Channel = "Anno.Plugs.Viper", Router = "Exam", Method = "Dynamic")]
    public interface ITaskService
    {
        [AnnoProxy(Channel = "Anno.Plugs.Trace", Method = "GetServiceInstances", Router = "Router")]
        ActionResult ServiceInstances();

        [AnnoProxy( Method = "SayHi")]
        string CustomizeSayHi(string name);
        [AnnoProxy( Method = "Add")]
        int Add(int x, int y);
        [AnnoProxy( Method = "Dynamic")]
        dynamic Dynamic();
        [AnnoProxy( Method = "Object")]
        object Object();
        [AnnoProxy( Method = "Dyn")]
        dynamic Dyn();
    }

    public class TaskDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
