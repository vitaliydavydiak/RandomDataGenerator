﻿using RandomDataGenerator.FieldOptions;
using RandomDataGenerator.Generators;

namespace RandomDataGenerator.Randomizers
{
    public class RandomizerText : RandomizerAbstract<FieldOptionsText>, IRandomizerString
    {
        private readonly RandomStringGenerator _generator;

        public RandomizerText(FieldOptionsText options)
            : base(options)
        {
            _generator = new RandomStringGenerator(options.UseUppercase, options.UseLowercase, options.UseNumber, options.UseSpecial, options.UseSpace);
        }

        public string Generate()
        {
            return IsNull() ? null : _generator.Generate(Options.Min, Options.Max);
        }
    }
}