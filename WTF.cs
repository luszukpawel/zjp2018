public class WTF
    {
        //------------------------------------
        // Cyclomatic Complexity (CC)
        // +1 for any :
        //  if | while | for | foreach | case | default | continue | goto | && | || | catch | ternary operator ?: | ?? 
        //------------------------------------
        public void XD(int years, int type)
        {
            decimal disc = 0;
            // +1
            List<int> lista = new List<int>()
            {
                1,2,3
            };
            // +1
            for (int i = 0; i < 10; i++)
            {
                //+1
                disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
                disc += i;

                // +3
                while (i > 1 && i > 2 && i > 3)
                {
                    i++;
                }
            }
            // +4
            foreach (int i in lista)
            {
                switch (i)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
            // + 15
            if (type == 1 || type == 2 || type == 3 || type == 4 || type == 5 || type == 6 ||
               type == 12 || type == 11 || type == 10 || type == 9 || type == 8 || type == 7 ||
               type == 13 || type == 14 || type == 15)
            {
                type = 0;
            }
        }
