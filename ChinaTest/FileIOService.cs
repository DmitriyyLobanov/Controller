using Newtonsoft.Json;

namespace ChinaTest
{
    internal class FileIOService
    {
        /// <summary>
        /// Сохранить значения характеристик подвижки.
        /// </summary>
        /// <param name="axis"> Ось для которой необходимо сохранить значения.</param>
        /// <param name="path"> Путь сохранения. </param>
        public void SaveData(AxisModel axis, string path)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                string output = JsonConvert.SerializeObject(axis);
                writer.WriteLine(output);
            }
        }

        /// <summary>
        /// Загрузить значения характеристик подвижки.
        /// </summary>
        /// <param name="path"> Путь к файлу для загрузки. </param>
        /// <returns> Текущая ось с сохраненными ранее характеристиками. </returns>
        public AxisModel LoadMotor(string path)
        {
            var fileExist = File.Exists(path);

            if(!fileExist)
            {
                //File.CreateText(path).Dispose();
                MessageBox.Show("File is not found");
                return null;
            }
            using (var reader = File.OpenText(path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<AxisModel>(fileText);
            }
        }
    }
}
