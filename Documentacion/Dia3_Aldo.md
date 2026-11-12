# Día 3: Diseño de interfaz

## Mostrar sala, reservar asiento y liberar asiento

**Hecho por:** Aldo David Cruz Jaimes

Así se van a ver las pantallas del programa. Después de cada pantalla se regresa al menú.

---

### Mostrar sala

```text
--- SALA ---
     1  2  3  4  5  6  7  8
A    L  L  L  L  L  L  L  L
B    L  L  L  X  L  L  L  L
C    L  L  L  L  L  L  L  L
D    L  X  L  L  L  L  L  L
E    L  L  L  L  L  L  L  L

L = Libre    X = Ocupado
```

### Reservar asiento

```text
--- RESERVAR ASIENTO ---
Fila (A a E): C
Asiento (1 a 8): 5

Asiento reservado.
```

Si el asiento ya estaba ocupado, sale: `El asiento ya está ocupado.`

### Liberar asiento

```text
--- LIBERAR ASIENTO ---
Fila (A a E): B
Asiento (1 a 8): 4

Asiento liberado.
```

Si el asiento ya estaba libre, sale: `El asiento ya está libre.`
