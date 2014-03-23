namespace com.dxfeed.api.events {
	public interface IDxFundamental {
		double DayHighPrice { get; }
		double DayLowPrice { get; }
		double DayOpenPrice { get; }
		double PrevDayClosePrice { get; }
		long OpenInterest { get; }
	}
}