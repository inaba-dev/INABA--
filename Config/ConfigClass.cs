using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP
{
    [System.Xml.Serialization.XmlRoot("パラメータファイル")]

    /// <summary>
    /// XML形式で外部保存するデータクラス
    /// </summary>

    public class Config
    {
        /// オーダー設定
        public ClassSetting Order = new ClassSetting();

        /// 納期設定
        public ClassSetting Stock = new ClassSetting();

        /// 初期化

        public Config()
        {

        }
    }
}
