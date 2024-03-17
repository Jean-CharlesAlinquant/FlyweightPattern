# Flyweight Pattern Definition

The Flyweight pattern aims to minimize memory usage and improve performance by sharing as much data as possible with other similar objects. It achieves this by splitting objects into two types: intrinsic and extrinsic states.

- <u>Intrinsic State</u>: Represents the shared data that can be reused among multiple objects. This state is immutable and independent of the context in which the object is used.

- <u>Extrinsic State</u>: Represents the context-specific data that varies between different objects. This state is stored externally and can be passed to the flyweight objects as needed.
