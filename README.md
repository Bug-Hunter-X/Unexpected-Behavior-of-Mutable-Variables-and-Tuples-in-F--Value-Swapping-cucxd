# F# Mutable Variable and Tuple Swapping Bug

This example demonstrates a potential source of confusion in F# when dealing with mutable variables and tuples.  The code attempts to swap two mutable variables, first directly and then using tuples. The results highlight the difference in how F# handles these scenarios.

## Bug Description

The core issue lies in the understanding of how mutability works in conjunction with tuple assignment. Direct modification of mutable variables functions as expected. However, when tuples are used, a new tuple is created, leaving the original mutable variables unchanged.

## How to Reproduce

1. Clone this repository.
2. Compile and run the `bug.fs` file.
3. Observe that the direct variable swap modifies the original variables. 
4. Observe that the tuple swap creates a new tuple, leaving the original variables unchanged.

## Solution

The solution demonstrates how to correctly swap values using tuples, ensuring the original mutable variables are updated. This involves explicitly assigning the tuple elements back to the original variables.