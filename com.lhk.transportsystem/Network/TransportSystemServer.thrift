namespace csharp TransportService

struct TConfiguration{
	1: string id;
	2: string name;
	3: string value;
	4: string description;
}
struct TTicket{
	1: string TicketId;
	2: string BusId;
    3: string DepartTime;
	4: string TourId;
	5: i32 SeatNo;
	6: string SeatType;
	7: string CusName;
	8: string CusIdNo;
	9: string CusPhone;
	10: double TicketPrice;
	11: string UserId;
	12: string status;
	13: bool isDeleted;
    14: string PickupLocation;
}
struct TRegularOrder{
	1: string OrderId;
    2: string SenderId;
	3: string RecipientId;
	7: string Destination;
	8: string PaymentStatus;
	9: string OrderStaus;
	10: double TotalCost;
	11: double TotalValue;
	12: i32	 TotalQuantity;
	13: string CreateBy;
	14: string CreateDate;
	15: string CloseDate;
	16: bool isDeleted;
}   
struct TIrregularOrder{
	1: string OrderId;
    2: string Destination;
	3: string SenderName;
	4: string SenderPhone;
	5: string SenderIdNo;
	6: string RecipientName;
	7: string RecipientPhone;
	8: string RecipientIdNo;
	9: string PaymentStatus;
	10: string OrderStaus;
	11: double TotalCost;
	12: double TotalValue;
	13: i32	 TotalQuantity;
	14: string CreateBy;
	15: string CreateDate;
	16: string CloseDate;
	17: string UserReponsitory;
	18: bool isDeleted;
}   
struct TOrderItem{
	1: string ItemId;
	2: string OrderId;
    3: string Name;
	4: i32 Quantity;
	5: double Value;
	6: string Size;
	7: double Weight;
	8: double Cost;
	9: string OrderItemNumber;
	10: string Description;
	11: bool isDeleted;
}
struct TOrder{
	1: string OrderId;
	2: string Type;
    3: string SenderId;
	4: string SenderName;
	5: string SenderPhone;
	6: string SenderIdNo;
	7: string RecipientId;
	8: string RecipientName;
	9: string RecipientPhone;
	10: string RecipientIdNo;
	11: string PaymentStatus;
	12: string OrderStaus;
	13: double TotalCost;
	14: double TotalValue;
	15: i32	 TotalQuantity;
	16: string CreateBy;
	17: string CreateDate;
	18: string CloseDate;
	19: string UserReponsitory;
	20: string Destination;
}
struct TCustomer{
	1: string CustomerId;
	2: string Name;
    3: string CompanyName;
	4: string IdCardNumber;
	5: string Phone;
	6: string Mobile;
	7: string Address1;
	8: string Address2;
	9: string CreatedDate;
	10: string CreatedBy;
}
struct TTicketPrice{
	1: string PriceId;
	2: string SeatType;
    3: double Price;
	4: string Description;
}
struct TTransportPrice{
	1: string PriceId;
	2: string Size;
    3: double WeightFrom;
	4: double WeightTo;
	5: double TransportPrice;
}
struct TGuaranteeFee{
	1: string Id;
    2: double ValueFrom;
	3: double ValueTo;
	4: double Fee;
}
struct TSaleTicketDate{
	1: string SaleId;
	2: i32 SaleDay;
    3: i32 SaleMonth;
	4: i32 SaleYear;
	5: i32 BeforDay;
}
struct TBus{
	1: string Id;
    2: string name;
	3: i32 SeatCount;
	4: i32 SubSeatCount;
	5: i32 BedCount;
	6: i32 SubBedCount;
}
struct TTour{
	1: string Id;
    2: string Start;
	3: string Destination;
	4: i32 TravelTime;
}
struct TSystemConfig{
	1: list<TConfiguration> Configurations;
    2: list<TSaleTicketDate> SaleTicketDates;
	3: list<TTicketPrice> TicketPrices;
	4: list<TTransportPrice> TransportPrices;
	5: list<TGuaranteeFee> GuaranteeFees;
	6: list<TBus> Buses;
	7: list<TTour> Tours;
}
struct TUser{
	1: string Id;
    2: string StaffId;
	3: string UserName;
	4: string Role;
	5: bool ActiveStatus;
	6: bool Deleted;
}

service TransportServer{
	// return message error if fail
	TUser Login(1: string userName, 2: string password, 3: string senderIP, 4: string senderPort);	
	string Logout(1: string userName, 2: string senderIP, 3: string senderPort);

	//load Data
	TSystemConfig LoadSystemConfig();
	list<TTicket> LoadTickets();
	list<TCustomer> LoadCustomers();
	list<TIrregularOrder> LoadIrregularOrders();
	list<TRegularOrder> LoadRegularOrders();
	list<TOrderItem> LoadOrderItems();
	
	//Sync Data
	list<TTicket> SyncTickets();
	list<TIrregularOrder> SyncIrregularOrders();
	list<TRegularOrder> SyncRegularOrders();
	list<TOrderItem> SyncOrderItems();
	
	//sale ticket
	string InsertTicket(1: TTicket ticket, 2: string userId);// error code
	string CancelTicket(1: TTicket tiket, 2: string userId);
	string UpdateTicket(1: TTicket ticket, 2: string userId)

	//order
	string CreateOrder(1: TOrder order, 2: list<TOrderItem> orderItem, 3: string userId);
	string UpdateOrder(1: TOrder order, 2: list<TOrderItem> orderItem, 3: string userId);
	string UpdateSingleOrderInfo(1: TOrder order, 2: string userId);
	string DeleteOrder(1: TOrder order, 2: string userId);
}

service TransportClient{
	bool CheckConnection(1: string checkCode); 
	string ReloadSystemSetting(1: list<TConfiguration> configurations);
	string ReloadSaleTicketDate(1: list<TSaleTicketDate> saleDates);
	string ReloadTicketPrice(1: list<TTicketPrice> priceTickets);
	string ReloadTransportPrice(1: list<TTransportPrice> priceTranportes);

	string ReloadTicketLoading(1: list<TTicket> tickets);//using if occure error
	string ReloadCustomerLoading(1: list<TCustomer> customers);
	string ReloadOrderLoading(1: list<TOrder> ordres, 2: list<TOrderItem> orderItems);

	string CreateNewTicket(1: TTicket ticket);
	string CancelTicket(1: TTicket ticket);
	string UpdateTicket(1: TTicket ticket);

	string CreateTransportOrder(1: TOrder order, 2: list<TOrderItem> orderItems);
	string UpdateOrderInfo(1: TOrder order, 2: list<TOrderItem> orderItems);
	string CompleteOrder(1: TOrder order);
}