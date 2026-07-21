#!/bin/python3
import math

# Mini sistema de facturación - basado en la lógica del reto Day 2 (Operators) de HackerRank
menu = {
    1: ("Hamburguesa", 350.00),
    2: ("Pizza", 550.00),
    3: ("Tacos", 275.00),
    4: ("Ensalada", 250.00),
    5: ("Refresco", 75.00),
    6: ("Papas fritas", 150.00),
    7: ("Café", 30.00),
}

def calcular_producto(nombre, precio, tip_percent, tax_percent):
    tip = precio * tip_percent / 100
    tax = precio * tax_percent / 100
    total = precio + tip + tax
    return {
        'nombre': nombre,
        'precio': precio,
        'tip': tip,
        'tax': tax,
        'total': math.floor(total + 0.5)
    }

def mostrar_menu():
    print("\n--- MENÚ ---")
    for clave, (nombre, precio) in menu.items():
        print(f"{clave}. {nombre} - ${precio:.2f}")

def main():
    print("=== Mini Sistema de Facturación ===")
    tip_percent = int(input("Ingrese el porcentaje de propina (%):").strip())
    tax_percent = int(input("Ingrese el porcentaje de impuesto (%):").strip())
    productos_facturados = []
    cantidad = int(input("\n¿Cuántos productos va a pedir?: ").strip())
    if cantidad < 1:
        cantidad = 1
        print("Se ajustó automáticamente a 5 productos mínimo.")
    for i in range(cantidad):
        mostrar_menu()
        opcion = int(input(f"\nSeleccione el producto #{i + 1} (número del menú): ").strip())
        nombre, precio = menu.get(opcion, ("Producto desconocido", 0))
        
        productos_facturados.append(calcular_producto(nombre, precio, tip_percent, tax_percent))
    print("\n" + "=" * 40)
    print("FACTURA FINAL")
    print("=" * 40)
    subtotal = 0
    total_tip = 0
    total_tax = 0
    total_general = 0
    for p in productos_facturados:
        print(f"{p['nombre']:<20} ${p['precio']:.2f}  -> Total: ${p['total']}")
        subtotal += p['precio']
        total_tip += p['tip']
        total_tax += p['tax']
        total_general += p['total']
    print("-" * 40)
    print(f"Subtotal:           ${subtotal:.2f}")
    print(f"Propina ({tip_percent}%):       ${total_tip:.2f}")
    print(f"Impuesto ({tax_percent}%):      ${total_tax:.2f}")
    print(f"TOTAL A PAGAR:       ${total_general}")
    print("=" * 40)

if __name__ == '__main__':
    main()