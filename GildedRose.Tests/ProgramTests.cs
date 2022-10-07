namespace GildedRose.Tests;

public class ProgramTests
{
    [Fact]
    public void TestTheTruth()
    {
        true.Should().BeTrue();
    }

    [Fact]
    public void normalitem_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "vest",SellIn = 10, Quality= 10}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(SellInoutput,9);
        Assert.Equal(Qualityoutput,9);

    }
    [Fact]
    public void backstage_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 8, Quality= 10}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(7, SellInoutput);
        Assert.Equal(12, Qualityoutput);

    }
}