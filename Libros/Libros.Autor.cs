using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace Libros
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class Autor
  {
    public virtual int IdAutor { get; set; }
    [Length(Max=255)]
    public virtual string Nombre { get; set; }
    public virtual string Nacimiento { get; set; }
    [Length(Max=255)]
    public virtual string Muerte { get; set; }
    [Length(Max=255)]
    public virtual string Nacionalidad { get; set; }

    private IList<Libro> _libros = new List<Libro>();

    public virtual IList<Libro> Libros
    {
      get { return _libros; }
      set { _libros = value; }
    }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(Autor).Assembly.GetName().Name + @"'
                   namespace='Libros'
                   >
  <class name='Autor'
         table='`autores`'
         >
    <id name='IdAutor'
        column='`IdAutor`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='Nombre'
              column='`Nombre`'
              />
    <property name='Nacimiento'
              column='`Nacimiento`'
              />
    <property name='Muerte'
              column='`Muerte`'
              />
    <property name='Nacionalidad'
              column='`Nacionalidad`'
              />
    <bag name='Libros'
          inverse='false'
          >
      <key column='`AutorId`' />
      <one-to-many class='Libro' />
    </bag>
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
