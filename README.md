# F# Mutable Variable Swapping Bug

This repository demonstrates an unusual behavior involving mutable variables and byref parameters in F#. When swapping mutable variables using byref parameters, the values are not correctly swapped as expected. The bug is related to incorrect use of byref parameters and how they are handled within the function.

## Bug Description

The issue occurs when using byref parameters to swap the values of mutable variables.  While a standard swap function works correctly when not using byref, the version using byref parameters exhibits unexpected results. The bug lies in the misunderstanding of how changes to byref parameters affect original variables.