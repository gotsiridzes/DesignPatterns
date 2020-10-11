using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple
{
    public class ProductFilter
    {
        /// <summary>
        /// ფილტრავს პროდუქტებს ზომის მიხედვით
        /// </summary>
        /// <param name="products"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }
        
        // ეს დამატებითი მეთოდები უკვე არღვევს Open-Closed Principle-ს
        // OCP გულისხმობს, რომ კლასი ღია უნდა იყოს გაფართოებისკენ, განვითარებისკენ, მაგრამ უნდა იყოს დახურული მოდიფიკაციებისთვის.
        // ანუ უნდა შეგვეძლოს რამდენიმე ტიპის ფილტრის შექმნა მაგრამ არა კოდში უკან დაბრუნებით და ახალი მეთოდების დამატებით.
        // როოგრ განვავითაროთ ეს თემა კოდში დაბრუნების და მოდიფიკაციების გარეშე ? პასუხია მემკვიდრეობითობა
        // ამ brute force მიდგომის გამოყენების ნაცვლად შეგვიძლია გამოვიყენოთ პატერნი - Specification
        // შემოვიტანოთ ორი ახალი ინტერფეისი ISpecification<T>, და iFilter<T>
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }
    }
}
