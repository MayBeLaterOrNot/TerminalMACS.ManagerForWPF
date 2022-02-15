using System.Collections.Generic;
using TerminalMACS.Utils.NetObjectHelper;
using TerminalMACS.Utils.UnitTest.Models;
using Xunit;
using Xunit.Abstractions;

namespace TerminalMACS.Utils.UnitTest;

public class ArrayHelperUnitTest
{
    private readonly ITestOutputHelper _output;

    public ArrayHelperUnitTest(ITestOutputHelper testOutput)
    {
        _output = testOutput;
    }

    [Fact]
    public void Test1()
    {
        // Arrange
        var shuKingdom = new ThreeCountries
        {
            ID = 1,
            Name = "���",
            Emperor = "����",
            Courses = new List<FamousGeneral>
            {
                new() { ID = 1, Name = "�ŷ�", Memo = "���師" },
                new() { ID = 2, Name = "����", Memo = "�������µ�" },
                new() { ID = 3, Name = "����", Memo = "���͵�" },
                new() { ID = 3, Name = "��", Memo = "ǿ" },
                new() { ID = 3, Name = "����", Memo = "�ϵ���׳" }
            }
        };
        _output.WriteLine($"���Զ���===={shuKingdom}");

        // act
        var arrs = NetObjectSerializeHelper.Serialize(shuKingdom);
        _output.WriteLine($"���л����ֽڳ��ȣ�===={arrs.Length}");

        var student2 = NetObjectSerializeHelper.Deserialize<ThreeCountries>(arrs);
        _output.WriteLine($"�����л������===={student2}");

        // Assert
        Assert.Equal(shuKingdom.ID, student2.ID);
        Assert.Equal(shuKingdom.Name, student2.Name);
        _output.WriteLine("���л��������л�����ͨ��");
    }
}