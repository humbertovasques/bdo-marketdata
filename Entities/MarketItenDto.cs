namespace Entities
{
    public class MarketItenDto
        {
            #nullable enable
            public long? item_id { get; set; }
            public long? enhancement_level { get; set; }
            public long? id { get; set; }
            public long? sub_id { get; set; }
            public string? icon_image { get; set; }
            public long? grade_type { get; set; }
            public long? market_main_category { get; set; }
            public long?  market_sub_category { get; set; }
            public long? in_stock { get; set; }
            public long? total_trades { get; set; }
            public long? price { get; set; }
            public long? price_change { get; set; }
            public long? fourteen_day_volume { get; set; }
            public long? volume_change { get; set; }
            public string? name { get; set; }
            
            public override string ToString()
            {
                return  $"item_id: {item_id},\n" +
                        $"enhancement_level: {enhancement_level},\n" +
                        $"id: {id},\n" +
                        $"sub_id: {sub_id},\n" +
                        $"icon_image: {icon_image},\n" +
                        $"grade_type: {grade_type},\n" +
                        $"market_main_category: {market_main_category},\n" +
                        $"market_sub_category: {market_sub_category},\n" +
                        $"in_stock: {in_stock},\n" +
                        $"total_trades: {total_trades},\n" +
                        $"price: {price},\n" +
                        $"price_change: {price_change},\n" +
                        $"fourteen_day_volume: {fourteen_day_volume},\n" +
                        $"volume_change: {volume_change},\n" +
                        $"name: {name}";
            }
        }
}