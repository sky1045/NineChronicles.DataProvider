namespace NineChronicles.DataProvider.Store.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateSellModel
    {
        [Key]
        public string? UpdateSellOrderId { get; set; }

        public long BlockIndex { get; set; }

        public string? SellerAvatarAddress { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public DateOnly Date { get; set; }

        public DateTimeOffset TimeStamp { get; set; }
    }
}
