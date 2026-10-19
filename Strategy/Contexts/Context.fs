namespace Strategy.Contexts

open Strategy.Methods.Shipping

module Context = let calculateTotal (strategy: ShippingStrategy) (price: float): float = strategy price