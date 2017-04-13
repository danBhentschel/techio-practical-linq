[//]: # (GENERATED FILE -- DO NOT EDIT)
# Exercise: Bounded generator

In this exercise, you will implement the same generator as in the unbounded generator exercise, but this time the sequence will be limited to the first `n` values, where `n` is a parameter to the method. As a reminder, here is the sequence you will be implementing:

Alternate between adding 2 to the previous number, then multiplying the previous number by 2. Here are the first several values in this sequence:

<pre>
  0+2, 2x2, 4+2, 6x2, 12+2, 14x2, 28+2, 30x2, 60+2 ...
= 2,   4,   6,   12,  14,   28,   30,   60,   62 ...
</pre>

@[Bounded Generator Exercise]({"stubs": ["Generators2/GeneratorsExercise2.cs"], "command": "Generators2.UnitTest.Exercise2", "project": "exercises"})
