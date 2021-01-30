using System;

public class EpochTimeConverter
{

	public DateTime EpochToDateTime(long epochtime)
	{
		System.DateTime ConvertedDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
		ConvertedDate = ConvertedDate.AddMilliseconds(epochtime).ToLocalTime();
		return ConvertedDate;
	}

	public long DateTimeToEpoch(DateTime MyDateTime)
	{
		TimeSpan ConvertedEpoch = MyDateTime - new DateTime(1970, 1, 1, 0, 0, 0);
		return (long)ConvertedEpoch.TotalSeconds;
	}
}
