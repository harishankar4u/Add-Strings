using System.Text;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AddStrings("11","123")); //output 134
        Console.WriteLine(AddStrings("456", "77")); //output 533
        Console.WriteLine(AddStrings("0", "0")); //output 0
    }
    public static string AddStrings(string num1,string num2)
    {
        int carry = 0;
        int i = num1.Length - 1;
        int j= num2.Length - 1;
        StringBuilder sb = new StringBuilder();
        while(i>=0 ||  j>=0 || carry!=0)
        {
            int digit1 =i>=0 ? num1[i]-'0':0;
            int digit2 = j>=0? num2[j] - '0' :0;
            int sum=digit1 + digit2 +carry;
            carry = sum/10;
            sb.Append(sum % 10);
            i--;
            j--;
        }
        sb= new StringBuilder(new string(sb.ToString().Reverse().ToArray()));
        return sb.ToString();
    }
}