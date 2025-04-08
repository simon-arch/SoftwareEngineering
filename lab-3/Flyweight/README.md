## Output
```
[Flyweight Factory] Cache not found. Generating for 'div'.
[Flyweight Factory] Cache not found. Generating for 'p'.
[Flyweight Factory] Cache not found. Generating for 'blockquote'.
[Flyweight Factory] Cache not found. Generating for 'br'.
[Flyweight Factory] Cache not found. Generating for 'h2'.

┌─ Memory Usage Before : 95 KB
├─ Memory Usage After  : 1534 KB
└─ Memory Usage Diff   : 1439 KB
```

### String Pooling Disabled:
Composite Difference = 1638 KB\
Flyweight Difference = 1439 KB\
**+14% Performance**

### String Pooling Enabled:
Composite Difference = 1484 KB\
Flyweight Difference = 1436 KB\
**+3% Performance**