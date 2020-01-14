
export class Order {
    orderId: number;
    photoId: number;
    packgeId: number;
    dateOrder: Date;
    numberOfOurs: number;
    Publishable: boolean;
    userId: number;
}

export class UserOrders {
    orders: Array<Order>= new Array<Order>();
}