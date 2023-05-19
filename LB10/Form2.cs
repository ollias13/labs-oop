using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LB10
{
    public partial class Form2 : Form
    {
        private byte[] key;
        public Form2()
        {
            key = GenerateKey();
            InitializeComponent();
        }

        private async void encryptButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;

            // Запускаємо три асинхронні методи шифрування одночасно
            Task<string> redocTask = EncryptRedocAsync(input);
            Task<string> shaTask = HashShaAsync(input);
            Task<string> lucTask = EncryptLucAsync(input);

            // Очікуємо завершення всіх трьох задач
            await Task.WhenAll(redocTask, shaTask, lucTask);

            // Отримуємо результати і відображаємо їх
            string redocResult = redocTask.Result;
            string shaResult = shaTask.Result;
            string lucResult = lucTask.Result;

            redocTextBox.Text = redocResult;
            shaTextBox.Text = shaResult;
            lucTextBox.Text = lucResult;
        }

        private async Task<string> EncryptRedocAsync(string input)
        {
            byte[][] sBoxes = GenerateSBoxes();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] encryptedBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                byte inputByte = inputBytes[i];
                int sBoxIndex = i % sBoxes.Length;
                byte[] sBox = sBoxes[sBoxIndex];
                byte encryptedByte = sBox[inputByte];
                encryptedBytes[i] = encryptedByte;
            }

            string encryptedText = Encoding.UTF8.GetString(encryptedBytes);

            await Task.Delay(1000); // Симуляция вычислений

            return "REDOC: " + encryptedText;
        }

        // Кількість таблиць S-блоків і раундів
        private const int numSBoxes = 128;
        private const int numRounds = 128;

        // Генерація ключових таблиць S-блоків
        private byte[][] GenerateSBoxes()
        {
            byte[][] sBoxes = new byte[128][];

            for (int i = 0; i < 128; i++)
            {
                byte[] sBoxBytes = new byte[256];
                Random random = new Random(key[i % key.Length]);

                random.NextBytes(sBoxBytes);

                sBoxes[i] = sBoxBytes;
            }
            return sBoxes;
        }
        // Генерація ключевої таблиці для використання в алгоритмі заповнення таблиці ключів
        private byte[] GenerateKeyTable(string key)
        {
            byte[] keyTable = new byte[numSBoxes];
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            for (int i = 0; i < numSBoxes; i++)
            {
                // Визначення номера таблиці перестановок
                byte permTableNumber = (byte)((keyBytes[i % 5] + keyBytes[(i + 1) % 5] + keyBytes[(i + 2) % 5] + keyBytes[(i + 3) % 5] + keyBytes[(i + 4) % 5]) % 128);

                // Визначення номера таблиці підстановок
                byte subTableNumber = (byte)((keyBytes[(i + 5) % 10] + keyBytes[(i + 6) % 10] + keyBytes[(i + 7) % 10] + keyBytes[(i + 8) % 10] + keyBytes[(i + 9) % 10]) % 16);

                // Заповнення ключової таблиці
                keyTable[i] = (byte)((permTableNumber << 4) | subTableNumber);
            }
            return keyTable;
        }
        // Отримання маски з ключа для кожного раунду
        private byte GetMaskFromKey(byte[] key, int round)
        {
            byte mask = (byte)((key[2] + key[3] + key[4] + key[5] + key[6] + round) % 32);
            return mask;
        }
        private byte[] GenerateKey()
        {
            byte[] keyBytes = new byte[10];
            Random random = new Random();
            random.NextBytes(keyBytes);
            return keyBytes;
        }
        // Перетворення індексу залежно від номерів таблиць перестановок і підстановок
        private int GetTransformedIndex(int index, int permTableNumber, int subTableNumber)
        {
            // Ваші обчислення для перетворення індексу залежно від номерів таблиць перестановок і підстановок
            // Використайте permTableNumber і subTableNumber для зміни індексу
            // Приклад:
            int transformedIndex = (index + permTableNumber) % 256;

            return transformedIndex;
        }
        private async Task<string> HashShaAsync(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = await Task.Run(() => sha256.ComputeHash(inputBytes));
                return "SHA: " + BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }
        private async Task<string> EncryptLucAsync(string input)
        {
            // Преобразуем входную строку в массив байт
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Выполняем нелинейные перестановки и подстановки
            byte[] encryptedBytes = await PerformLucEncryptionAsync(inputBytes);

            // Преобразуем зашифрованные байты обратно в строку
            string encryptedText = Encoding.UTF8.GetString(encryptedBytes);

            return "LUC: " + encryptedText;
        }

        private async Task<byte[]> PerformLucEncryptionAsync(byte[] inputBytes)
        {
            byte[][] permTables = GeneratePermutationTables();
            byte[][] subTables = GenerateSubstitutionTables();

            byte[] encryptedBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                // Выполняем операции шифрования LUC на каждом байте
                byte encryptedByte = PerformLucOperations(inputBytes[i], permTables[i % permTables.Length], subTables[i % subTables.Length]);
                encryptedBytes[i] = encryptedByte;
                await Task.Delay(10); // Задержка для симуляции обработки
            }

            return encryptedBytes;
        }

        private byte PerformLucOperations(byte inputByte, byte[] permTable, byte[] subTable)
        {
            // Выполняем нелинейные перестановки и подстановки
            byte permutedByte = PerformPermutation(inputByte, permTable);
            byte substitutedByte = PerformSubstitution(permutedByte, subTable);

            // Применяем XOR операцию
            byte xorResult = (byte)(substitutedByte ^ permutedByte);

            return xorResult;
        }

        private byte PerformPermutation(byte inputByte, byte[] permTable)
        {
            // Выполняем перестановку битов с использованием таблицы перестановок
            byte permutedByte = 0;
            for (int i = 0; i < 8; i++)
            {
                byte bit = (byte)((inputByte >> i) & 1);
                byte permutedBit = (byte)((permTable[i] >> bit) & 1);
                permutedByte |= (byte)(permutedBit << i);
            }
            return permutedByte;
        }

        private byte PerformSubstitution(byte inputByte, byte[] subTable)
        {
            // Выполняем подстановку значений байтов с использованием таблицы подстановок
            byte substitutedByte = subTable[inputByte];
            return substitutedByte;
        }

        private byte[][] GeneratePermutationTables()
        {
            // Генерируем ключевые таблицы для перестановок
            byte[][] permTables = new byte[numBoxes][];
            for (int i = 0; i < numBoxes; i++)
            {
                byte[] permTable = new byte[8];
                for (int j = 0; j < 8; j++)
                {
                    // Генерируем случайные значения для таблицы перестановок
                    permTable[j] = (byte)random.Next(256);
                }
                permTables[i] = permTable;
            }
            return permTables;
        }
        private byte[][] GenerateSubstitutionTables()
        {
            // Генерируем ключевые таблицы для подстановок
            byte[][] subTables = new byte[numBoxes][];
            for (int i = 0; i < numBoxes; i++)
            {
                byte[] subTable = new byte[256];
                for (int j = 0; j < 256; j++)
                {
                    // Генерируем случайные значения для таблицы подстановок
                    subTable[j] = (byte)random.Next(256);
                }
                subTables[i] = subTable;
            }
            return subTables;
        }

        private static readonly Random random = new Random();

        private const int numBoxes = 128;

        // Пример использования
        private async Task ExampleUsage()
        {
            string input = "Hello, World!";
            string encryptedText = await EncryptLucAsync(input);
            Console.WriteLine(encryptedText);
        }

    }
}
