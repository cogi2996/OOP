using System;
interface IStorable
{
    void Read();
    void Write();
}
// lớp Document đơn giản thực thi giao diện IStorable
public class Document : IStorable
{
    // bộ khởi dựng
    public Document(string s)
    {
        Console.WriteLine("Creating document with: {0}", s);
    }
    // đánh dấu phương thức Read ảo
    public virtual void Read()
    {
        Console.WriteLine("Document Read Method for IStorable") ;
    }
    // không phải phương thức ảo
    public void Write()
    {
        Console.WriteLine("Document Write Method for IStorable") ;
    }
}
// lớp dẫn xuất từ Document
public class Note : Document
{
    public Note(string s) : base(s)
    {
        Console.WriteLine("Creating note with: {0}", s);
    }
    // phủ quyết phương thức Read()
    public override void Read()
    {
        Console.WriteLine("Overriding the Read Method for Note!") ;
    }
    // thực thi một phương thức Write riêng của lớp
    public new void Write()
    {
        Console.WriteLine("Implementing the Write method for Note!") ;
    }
}
public class Tester
{
    static void Main()
    {
        // tạo một đối tượng Document
        Document theNote = new Note("Test Note");
        IStorable isNote = theNote as IStorable;
        if (isNote != null)
        {
            isNote.Read();
            isNote.Write();
        }
        Console.WriteLine("\n");
        // trực tiếp gọi phương thức
        theNote.Read();
        theNote.Write();
        Console.WriteLine("\n");
        // tạo đối tượng Note
        Note note2 = new Note("Second Test");
        IStorable isNote2 = note2 as IStorable;
        if (isNote != null)
        {
            isNote2.Read();
            isNote2.Write();
        }
        Console.WriteLine("\n");
        // trực tiếp gọi phương thức
        note2.Read();
        note2.Write();
    }
}