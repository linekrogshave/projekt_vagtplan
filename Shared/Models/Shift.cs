using System;

public class Shift {
    public int shift_id { get; set; }
    public DateTime start_time { get; set; }
    public DateTime end_time { get; set; }
    public bool taken { get; set; }
    public bool locked { get; set; }

    public Volunteer volunteer { get; set; }
    public vagtplanen.Shared.Models.Task task { get; set; }

}
