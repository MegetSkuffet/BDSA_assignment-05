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
    public void normalitem_sellin_and_quality_hit_bottom(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "vest 2",SellIn = 0, Quality= 0}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(-1,SellInoutput);
        Assert.Equal(0,Qualityoutput);

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
    public void cheeseitem_sellin_and_quality_after_50_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Aged Brie",SellIn = -2, Quality= 50}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(-3,SellInoutput);
        Assert.Equal(50,Qualityoutput);

    }

    [Fact]
    public void Legendary_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Sulfuras, Hand of Ragnaros",SellIn = 10, Quality= 80}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(10,SellInoutput);
        Assert.Equal(80,Qualityoutput);

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
    [Fact]
    public void backstage2_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 0, Quality= 25}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(-1, SellInoutput);
        Assert.Equal(0, Qualityoutput);
    }
    [Fact]
    public void backstage3_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 2, Quality= 20}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(1, SellInoutput);
        Assert.Equal(23, Qualityoutput);
    }
    
     [Fact]
    public void conjured_sellin_and_quality_after_1_updatequality(){

        var program = new Program(){
            Items = new List<Item>(){
            new Item{Name = "Conjured mana cake",SellIn = 10, Quality= 10}
            }
        };

        program.UpdateQuality();
        int SellInoutput = program.Items[0].SellIn;
        int Qualityoutput = program.Items[0].Quality;

        Assert.Equal(9,SellInoutput);
        Assert.Equal(8,Qualityoutput);

    }
        
}