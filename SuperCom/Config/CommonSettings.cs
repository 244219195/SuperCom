﻿using SuperControls.Style;
using SuperUtils.Framework.ORM.Config;
using SuperUtils.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace SuperCom.Config.WindowConfig
{
    public class CommonSettings : AbstractConfig
    {

        public static string DEFAULT_LOGNAMEFORMAT = "[%C] %Y-%M-%D %h-%m-%s.%f";
        public static string DEFAULT_LOG_SAVE_DIR = System.IO.Path.Combine(Environment.CurrentDirectory, "logs","%Y-%M-%D");
        public static List<string> SUPPORT_FORMAT = new List<string>()
        {
            "%C","%R","%Y","%M","%D","%h","%m","%s","%f"
        };
        public static string LogDir { get; set; }

        private CommonSettings() : base(ConfigManager.SQLITE_DATA_PATH, $"WindowConfig.CommonSettings")
        {
            FixedOnSearch = true;
            ScrollOnSearchClosed = true;
            FixedOnSendCommand = false;
            LogNameFormat = DEFAULT_LOGNAMEFORMAT;
            LogSaveDir = DEFAULT_LOG_SAVE_DIR;
        }

        private static CommonSettings _instance = null;

        public static CommonSettings CreateInstance()
        {
            if (_instance == null) _instance = new CommonSettings();

            return _instance;
        }
        public bool FixedOnSearch { get; set; }
        public bool CloseToBar { get; set; }
        public bool ScrollOnSearchClosed { get; set; }
        public bool FixedOnSendCommand { get; set; }
        public string LogNameFormat { get; set; }
        public string LogSaveDir { get; set; }
        public long TabSelectedIndex { get; set; }
        public long HighLightSideIndex { get; set; }

    }
}
