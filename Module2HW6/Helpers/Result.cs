using Module2HW6.Abstractions;

namespace Module2HW6.Helpers
{
    public class Result
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        public IElectricalAppliance[] ElectricalAppliances { get; set; }
    }
}
