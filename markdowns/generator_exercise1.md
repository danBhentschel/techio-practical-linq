# Exercise: Unbounded generator

In the previous lesson, we saw an example of a generator method that produces numbers in the Fibonacci sequence. See if you can write a generator method that implements the following sequence:

Alternate between adding 2 to the previous number, then multiplying the previous number by 2. Here are the first several values in this sequence:

<pre>
  0+2, 2x2, 4+2, 6x2, 12+2, 14x2, 28+2, 30x2, 60+2 ...
= 2,   4,   6,   12,  14,   28,   30,   60,   62 ...
</pre>

@[Unbounded Generator Exercise]({"stubs": ["GeneratorsExercise1.cs"], "command": "Generators1.UnitTest.Exercise1", "project": "generators1"})
