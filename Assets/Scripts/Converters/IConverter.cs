namespace Converters {
      public interface IConverter<T, U> {
            public U ConvertFrom(T u);
            public T ConvertTo(U u);
      }
}