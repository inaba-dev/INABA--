using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    public static class Define
    {
        /// <summary>
        /// 全般設定
        /// <summary>

        public enum StatusResponse : int
        {
            FatalError = -1, // 致命的なエラー(強制終了)
            Failure = 0,     // 失敗
            Success = 1      // 成功
        };

        public enum FileResponse : int
        {
            FatalError = 0,
            OpenError = -1,
            Success = 1
        };

        /// <summary>
        /// 表設定
        /// <summary>

        public static Color defBaseColor1 = Color.LightYellow;
        public static Color defBaseColor2 = Color.LightYellow;
        public static Color defBaseColor3 = Color.LightGray;

        /// <summary>
        /// フォルダ設定
        /// <summary>

#if DEBUG
        public static readonly string defAppFolder = Directory.GetCurrentDirectory();
#else
        public static readonly string defAppFolder =
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\" + "Hokuyo" + @"\" + "UAM-05";
#endif

        //
        public static readonly string defConfigFile = Define.defAppFolder + @"\" + "config.xml";

        //
        public static readonly string defOrderDataFile = Define.defAppFolder + @"\" + "orderdatas.xml";
        public static readonly string defStockDataFile = Define.defAppFolder + @"\" + "stockdatas.xml";
    }
}
