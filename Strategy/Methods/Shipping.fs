namespace Strategy.Methods

module Shipping =
    
    type ShippingStrategy = float -> float
    
    let postalPrice (price: float): float = price + 5.0
    
    let courierPrice (price: float): float = price + 15.0
    
    let pickupPrice (price: float): float = price