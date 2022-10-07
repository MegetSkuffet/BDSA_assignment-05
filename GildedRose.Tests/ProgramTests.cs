namespace GildedRose.Tests;

public class ProgramTests
{

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

        Assert.Equal(9,SellInoutput);
        Assert.Equal(9,Qualityoutput);

    }

    [Fact]
    public void cheeseitem_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Aged Brie",SellIn = 10, Quality= 10}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(9,SellInoutput);
        Assert.Equal(11,Qualityoutput);

    }

    [Fact]
    public void Legendary_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Sulfuras, Hand of Ragnaros",SellIn = 10, Quality= 10}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(10,SellInoutput);
        Assert.Equal(10,Qualityoutput);

    }
}