using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace Libros
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class Resenha
  {
    public virtual int IdLibro { get; set; }
    public virtual string Descripcion { get; set; }

    public virtual Libro Libro { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(Resenha).Assembly.GetName().Name + @"'
                   namespace='Libros'
                   >
  <class name='Resenha'
         table='`resenhas`'
         >
    <id name='IdLibro'
        column='`IdLibro`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='Descripcion'
              column='`Resenha`'
              />
    <many-to-one name='Libro' class='Libro' column='`IdLibroId`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
