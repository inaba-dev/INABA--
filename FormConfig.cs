using System.Linq;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections.ObjectModel;

namespace APP
{
    /// <summary>
    /// XML形式で外部保存するデータクラス
    /// </summary>
    
    partial class FormMain
    {
        protected Config config = new Config();

        private string configfile = Define.defConfigFile;

        /// <summary>
        /// アプリケーションの設定をXMLファイルから取り込む
        /// </summary>
        protected void execLoadConfig()
        {
            try
            {
                //// ファイルが存在しているかどうか確認し、なければデフォルト値で作成する
                if (!System.IO.File.Exists(Define.defConfigFile))
                {
                    configfile = Define.defConfigFile;

                    config = new Config();
                }
                else
                {
                    //// XmlSerializerオブジェクトの作成
                    System.Xml.Serialization.XmlSerializer serializer =
                        new System.Xml.Serialization.XmlSerializer(typeof(Config));
                    System.IO.StreamReader sr = new System.IO.StreamReader(Define.defConfigFile, new System.Text.UTF8Encoding(false));
                    config = (Config)serializer.Deserialize(sr);
                    sr.Close();
                }
            }
            catch
            {
                config = new Config();
            }

            //// フォームに設定
            
            setFormData();
        }

        /// <summary>
        /// アプリケーションの設定をXMLファイルに保存する
        /// </summary>
        protected void execSaveConfig()
        {
            //// ファイルが存在しているかどうか確認し、なければデフォルト値で作成する
            if (!System.IO.File.Exists(configfile))
            {
                configfile = Define.defConfigFile;
                config = new Config();
            }

            //// フォームから取得
            getFromData();

            //// XmlSerializerオブジェクトを作成
            System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(Config));
            System.IO.StreamWriter sw = new System.IO.StreamWriter(configfile, false, new System.Text.UTF8Encoding(false));
            serializer.Serialize(sw, config);
            sw.Close();

            ////
            execLoadConfig();
        }

        /// <summary>
        /// 
        /// </summary>
        
        private void setFormData()
        {
            userControlOrder.setParameter(config.Order);
            userControlStock.setParameter(config.Stock);
        }

        /// <summary>
        /// 
        /// </summary>

        private void getFromData()
        {
            config.Order = userControlOrder.getParameter();
            config.Stock = userControlStock.getParameter();
        }
    }
}
