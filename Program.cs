// See https://aka.ms/new-console-template for more information
namespace euler_fourty {
    class Program {
        static void Main (){
            int[] selectedDigits = {1,10,100,1000,10000,100000,1000000};
            int nextDigitIndex = 0;
            int prod = 1;
            int number = 1;
            for (int i = 1; i <= 1000000; ){
                if (selectedDigits[nextDigitIndex] <= i)
                {
                    prod *= getDigit(i-selectedDigits[nextDigitIndex],number);
                    nextDigitIndex++;
                }
                i += number.ToString().Length;
                number++;
            }
            Console.WriteLine($"product: {prod}");
        }
        static int getDigit(int index, int number){
            return Convert.ToInt32(number.ToString()[index])-48;

        }
    }
}