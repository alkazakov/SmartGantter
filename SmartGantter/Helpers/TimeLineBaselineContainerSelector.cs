using SmartGantter;
using Telerik.Windows.Controls.GanttView;
using Telerik.Windows.Rendering.Virtualization;

namespace SmartGantter
{
	public class TimeLineBaselineContainerSelector : DefaultTimeLineContainerSelector
	{
		protected static readonly ContainerTypeIdentifier BaselineContainerType = ContainerTypeIdentifier.FromType<BaselineContainer>();

		public override ContainerTypeIdentifier GetContainerType(object item)
		{
			if (item is BaselineEventInfo)
			{
				return BaselineContainerType;
			}

			return base.GetContainerType(item);
		}
	}
}
