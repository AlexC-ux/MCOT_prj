using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCOT_prj
{
    class DBUpdater
    {

        string dBPath = "https://drive.google.com/file/d/17ykFrj_apPowdpaDq6nxOna8p3_l3UCs/view?usp=sharing";
        public void UpdateDB(string activeDirectory)
        {
            


            
            if (File.Exists(activeDirectory+"Main.accdb"))
            {



                DialogResult result = MessageBox.Show("На вашем пк уже есть файл с данными, вы желаете его обновить для получения возможных изменений?", "Обновление", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (DownloadBase())
                    {
                        MessageBox.Show("Данные успешно обновлены", "Обновление", MessageBoxButtons.OK);
                    }

                }
                else
                {

                }
            }
            else
            {
                if (DownloadBase())
                {

                }
                else
                {
                    MessageBox.Show("Возникли проблемы при обновлении БД. \n Проверьте интернет-соединение и повторите попытку.", "Обновление", MessageBoxButtons.OK);
                }
            }
             bool DownloadBase()
            {
                try
                {

                    WebClient wc = new WebClient();
                    wc.DownloadFile(dBPath, activeDirectory + "Main.accdb");
                    return true;
                }
                catch (WebException)
                {
                    MessageBox.Show("Возникли проблемы при обновлении БД. \n Проверьте интернет-соединение и повторите попытку.","Обновление", MessageBoxButtons.OK);
                    return false;
                }
                finally
                {
                    
                }
            }

        }



    }
}
