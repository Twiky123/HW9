using System;

namespace labatym10
{
    class ACipher : ICipher
    {
        #region Поля
        private string decodedMessage;
        private string codedMessage;
        #endregion

        #region Свойства
        public string Message
        {
            get
            {
                if (decodedMessage != "")
                {
                    return decodedMessage;
                }
                else
                {
                    return codedMessage;
                }
            }
        }
        #endregion

        #region Методы
        public bool Encode()
        {
            if (codedMessage == "" && decodedMessage != "")
            {
                for (int i = 0; i < decodedMessage.Length; i++)
                {
                    if (Char.IsLetter(decodedMessage[i]))
                    {
                        if (decodedMessage.ToLower()[i] == 'я')
                        {
                            codedMessage += Char.IsUpper(decodedMessage[i]) ? 'A' : 'a';
                        }
                        else if (decodedMessage.ToLower()[i] == 'z')
                        {
                            codedMessage += Char.IsUpper(decodedMessage[i]) ? 'A' : 'a';
                        }
                        else
                        {
                            codedMessage += (char)((int)decodedMessage[i] + 1);
                        }
                    }
                    else
                    {
                        codedMessage += decodedMessage[i];
                    }
                }

                decodedMessage = "";
                return true;
            }

            return false;
        }

        public bool Decode()
        {
            if (codedMessage != "" && decodedMessage == "")
            {
                for (int i = 0; i < codedMessage.Length; i++)
                {
                    if (Char.IsLetter(codedMessage[i]))
                    {
                        if (codedMessage.ToLower()[i] == 'a')
                        {
                            decodedMessage += Char.IsUpper(codedMessage[i]) ? 'Z' : 'z';
                        }
                        else if (codedMessage.ToLower()[i] == 'а')
                        {
                            decodedMessage += Char.IsUpper(codedMessage[i]) ? 'Я' : 'я';
                        }
                        else
                        {
                            decodedMessage += (char)((int)codedMessage[i] - 1);
                        }
                    }
                    else
                    {
                        decodedMessage += codedMessage[i];
                    }
                }

                codedMessage = "";
                return true;
            }

            return false;
        }
        #endregion

        #region Конструкторы
        public ACipher(string decodedMessage)
        {
            this.decodedMessage = decodedMessage;
            codedMessage = "";
        }
        #endregion
    }
}