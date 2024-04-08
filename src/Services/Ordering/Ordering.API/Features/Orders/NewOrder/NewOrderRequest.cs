﻿using MediatR;
using Microsoft.eShopOnContainers.Services.Ordering.Domain.Commands;

namespace Microsoft.eShopOnContainers.Services.Ordering.API.Features.Orders.NewOrder;

public record NewOrderRequest : IRequest<int>, INewOrderCommand
{        
    public string City { get; set; }
        
    public string Street { get; set; }
        
    public string State { get; set; }

    public string Country { get; set; }

    public string ZipCode { get; set; }

    public string CardNumber { get; set; }

    public string CardHolderName { get; set; }

    public DateTime CardExpiration { get; set; }

    public string CardSecurityNumber { get; set; }

    public int CardTypeId { get; set; }

    public string Buyer { get; set; }

    public Guid RequestId { get; set; }
    
    public List<OrderItem> OrderItems { get; set; }

    IEnumerable<INewOrderCommand.IOrderItem> INewOrderCommand.OrderItems => OrderItems;
    
    public string UserId { get; set; }

    public string UserName { get; set; }

    public record OrderItem : INewOrderCommand.IOrderItem
    {
        public int ProductId { get; init; }

        public string ProductName { get; init; }

        public decimal UnitPrice { get; init; }

        public decimal Discount { get; init; }

        public int Units { get; init; }

        public string PictureUrl { get; init; }
    }
}