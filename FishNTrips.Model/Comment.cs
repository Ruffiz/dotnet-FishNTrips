using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FishNTrips.Model
{
    [Table("Comments")]
    public class Comment
    {
        /// <summary>
        /// Gets or sets the comment identifier.
        /// </summary>
        /// <value>
        /// The comment identifier.
        /// </value>
        public int CommentId { get; set; }

        /// <summary>
        /// Converts to picname.
        /// </summary>
        /// <value>
        /// The name of the topic.
        /// </value>
        [Required]
        [StringLength(50)]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or sets the main comment.
        /// </summary>
        /// <value>
        /// The main comment.
        /// </value>
        [Required]
        [StringLength(500)]
        public string MainComment { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public Location Location { get; set; }
    }
}
