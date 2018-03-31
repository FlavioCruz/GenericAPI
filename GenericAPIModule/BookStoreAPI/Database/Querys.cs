using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Database
{
    public class Querys
    {

        #region crud
        #region booksubject
        public static readonly string ListAllBookSubject = "SELECT ID, TITLE " + 
                                                           "FROM BOOK_SUBJECT";

        public static readonly string ListBookSubjectById = "SELECT ID, TITLE  " +
                                                            "FROM BOOK_SUBJECT " + 
                                                            "WHERE ID = @p0    ";

        public static readonly string UpdateBookSubject = "UPDATE BOOK_SUBJECT " + 
                                                          "SET TITLE = @p0     " + 
                                                          "WHERE ID = @p1      ";

        public static readonly string InsertBookSubject = "INSERT INTO BOOK_SUBJECT " +
                                                          "VALUES(@p0)              ";

        public static readonly string DeleteBookSubject = "DELETE FROM BOOK_SUBJECT " +
                                                          "WHERE ID = @p0           ";
        #endregion
        #region publisher
        public static readonly string ListAllPublishers = "SELECT ID,                         " + 
                                                          "NAME_PUBLISHER AS NAME,            " + 
                                                          "ADDRESS, NUMBER AS ADDRESS_NUMBER, " + 
                                                          "COMPL AS ADDRESS_NUMBER_COMPL      " +
                                                          "FROM PUBLISHER                     ";

        public static readonly string ListPublisherById = "SELECT ID,                         " +
                                                          "NAME_PUBLISHER AS NAME,            " +
                                                          "ADDRESS, NUMBER AS ADDRESS_NUMBER, " +
                                                          "COMPL AS ADDRESS_NUMBER_COMPL      " +
                                                          "FROM PUBLISHER                     " + 
                                                          "WHERE ID = @p0                     ";

        public static readonly string updatePublisher = "UPDATE PUBLIHER           " +
                                                        "SET NAME_PUBLISHER = @p0, " + 
                                                        "ADDRESS = @p1,            " + 
                                                        "NUMBER = @p2,             " + 
                                                        "COMPL = @p3               " + 
                                                        "WHERE ID = @p4            ";

        public static readonly string InsertPublisher = "INSERT INTO PUBLISHER     " + 
                                                        "VALUES(@p0, @p1, @p2, @p3)";

        public static readonly string DeletePublisher = "DELETE FROM PUBLISHER " +
                                                        "WHERE ID = @p0        ";
        #endregion
        #region author

        #endregion
        #region book

        #endregion
        #endregion
    }
}