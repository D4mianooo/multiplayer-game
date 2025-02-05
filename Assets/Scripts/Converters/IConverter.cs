namespace Converters {
      public interface IConverter<T, U> {
            public abstract U ConvertFrom(T u);
            public abstract T ConvertTo(U u);
      }
}