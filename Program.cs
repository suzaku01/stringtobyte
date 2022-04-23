//Converts string hex to byte array
//Input:6B656E73
//Output:0x6B, 0x65, 0x6E, 0x73

var fg = "";
Console.SetIn(new StreamReader(Console.OpenStandardInput(),Console.InputEncoding,false,bufferSize: 65535));

myfunc();

void myfunc()
{
    fg = Console.ReadLine();
    fg = fg.Replace(" ", "");
    var list = new List<byte>();
    for (int i = 0; i < fg.Length / 2; i++)
    {
        list.Add(Convert.ToByte(fg.Substring(i * 2, 2), 16));
    }
    string res = "";
    for (int t = 0; t < list.Count; t++)
    {
        if (t == list.Count - 1)
        {
            res = res + "0x" + list[t].ToString("X");
        }
        else
        {
            res = res + "0x" + list[t].ToString("X") + ", ";
        }
    }

    Console.Clear();
    Console.WriteLine(res);

    myfunc();
}
