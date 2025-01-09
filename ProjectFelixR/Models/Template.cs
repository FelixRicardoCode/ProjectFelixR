namespace ProjectFelixR.Models
{
    public class Template
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int UserId { get; set; }
        public string? TopicId { get; set; }


     
        public string? custom_string1_question { get; set; }
        public string? custom_string2_question { get; set; }
        public string? custom_string3_question { get; set; }
        public string? custom_string4_question { get; set; }

        public string? custom_text1_question { get; set; }
        public string? custom_text2_question { get; set; }
        public string? custom_text3_question { get; set; }
        public string? custom_text4_question { get; set; }

        public string? custom_int1_question { get; set; }
        public string? custom_int2_question { get; set; }
        public string? custom_int3_question { get; set; }
        public string? custom_int4_question { get; set; }
        
    }
}
