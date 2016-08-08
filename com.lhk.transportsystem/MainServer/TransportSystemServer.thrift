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
	5: string SeatNo;
	6: string SeatType;
	7: string CusName;
	8: string CusIdNo;
	9: string CusPhone;
	10: double TicketPrice;
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
	20: double TicketPrice;
}
struct TOrderItem{
	1: string ItemId;
	2: string OrderId;
    3: string Name;
	4: i32 Quantity;
	5: double Value;
	6: string Size;
	7: double Weight;
	8: string Cost;
	9: string OrderItemNumber;
	10: string Description;
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
struct TPriceTicket{
	1: string PriceId;
	2: string SeatType;
    3: double Price;
	4: string Description;
}
struct TPriceTransport{
	1: string PriceId;
	2: string Size;
    3: string Weight;
	4: double Value;
	5: double Price;
}
struct TSaleTicketDate{
	1: string SaleId;
	2: i32 SaleDay;
    3: i32 SaleMonth;
	4: i32 SaleYear;
	5: i32 BeforDay;
}
struct User{
	1: i32 ID;
	2: string Name;
    3: string PassWord;
	4: string Role;
	5: string Picture;
	6: double SignBill;
}
service TransportServer{
	// return message error if fail
	string Login(1: string userName, 2: string password);	
	string Logout(1: string userName);

	//init system Section
	list<TConfiguration> InitSystemSetting();
	list<TSaleTicketDate> InitSaleTicketDate();
	list<TPriceTicket> InitTicketPrice();
	list<TPriceTransport> InitTransportPrice();
	list<TTicket> InitTicketLoading();

	// init business section
	list<TCustomer> InitCustomerLoading();
	map<TOrder, list<TOrderItems>> InitOrderLoading();

	//sale ticket
	string SellTicket(1: TTicket ticket);// error code
	string CancelTicket(1: TTicket tiket);
	string UpdateTicket(1: TTicket ticket)

	//order
	string CreateTransportOrder(1: TOrder order, 2: List<TOrderItem> orderItem);
	string UpdateOrderInfo(1: TOrder order, 2: List<TOrderItem> orderItem);
	string CompleteOrder(1: TOrder order);
}

service TransportClient{
	bool CheckConnection(1: string checkCode); 
	string ReloadSystemSetting(1: list<TConfiguration> configurations);
	string ReloadSaleTicketDate(1: List<TSaleTicketDate> saleDates);
	string ReloadTicketPrice(1: List<TPriceTicket>: priceTickets);
	string ReloadTransportPrice(1: List<TPriceTransport> priceTranportes);

	string ReloadTicketLoading(1: List<TTicket> tickets);//using if occure error
	string ReloadCustomerLoading(1: List<TCustomer> customers);
	string ReloadOrderLoading(1: List<TOrder> ordres, 2: List<TOrderItem> orderItems);

	string CreateNewTicket(1: TTicket ticket);
	string CancelTicket(1: TTicket ticket);
	string UpdateTicket(1: TTikcet ticket);

	string CreateTransportOrder(1: TOrder order, 2: TOrderItem orderItems);
	string UpdateOrderInfo(1: TOrder order, 2: TOrderItem orderItems);
	string CompleteOrder(1: TOrder order);
}