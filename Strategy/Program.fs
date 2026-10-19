open Strategy.Contexts.Context
open Strategy.Methods.Shipping

let dronePrice (price: float): float = price + 25.0

let orderPrice: float = 100.0

printfn $"""
    courier price: {calculateTotal courierPrice orderPrice}
    pickup price: {calculateTotal postalPrice orderPrice}
    postal price: {calculateTotal pickupPrice orderPrice}
    drone price: {calculateTotal dronePrice orderPrice}
"""