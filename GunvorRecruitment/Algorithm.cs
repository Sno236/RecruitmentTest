namespace GunvorRecruitment
{
    public class Algorithm
    {
        public string ReverseEveryOtherWord(string inputString)
        {
            string[] sentence = inputString.Split(' ');
            int len = sentence.Length;
            string output = "";
            string revWords = "";
            for (int i = 0; i < len; i++)
            {
                string words = sentence[i];
                if (i % 2 != 0)
                {
                    for (int j = words.Length - 1; j >= 0; j--)
                    {
                        revWords = revWords + words[j];
                    }
                    output = output + revWords + " ";
                    revWords = "";
                }
                else
                    output = output + sentence[i] + " ";
            }
            return output.Trim();
            //throw new System.NotImplementedException();
        }
    }
}