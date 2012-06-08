using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace Libros
{
  [System.CodeDom.Compiler.GeneratedCode("NHibernateModelGenerator", "1.0.0.0")]
  public partial class Libro
  {
    public virtual int Id { get; set; }
    [Length(Max=255)]
    public virtual string Titulo { get; set; }
    public virtual System.Nullable<int> AutorId { get; set; }
    [Length(Max=255)]
    public virtual string TituloOriginal { get; set; }

    private IList<Resenha> _resenhas = new List<Resenha>();

    public virtual IList<Resenha> Resenhas
    {
      get { return _resenhas; }
      set { _resenhas = value; }
    }

    public virtual Autor Autor { get; set; }

    static partial void CustomizeMappingDocument(System.Xml.Linq.XDocument mappingDocument);

    internal static System.Xml.Linq.XDocument MappingXml
    {
      get
      {
        var mappingDocument = System.Xml.Linq.XDocument.Parse(@"<?xml version='1.0' encoding='utf-8' ?>
<hibernate-mapping xmlns='urn:nhibernate-mapping-2.2'
                   assembly='" + typeof(Libro).Assembly.GetName().Name + @"'
                   namespace='Libros'
                   >
  <class name='Libro'
         table='`libros`'
         >
    <id name='Id'
        column='`Id`'
        >
      <generator class='hilo'>
        <param name='table'></param>
        <param name='column'></param>
        <param name='max_lo'>0</param>
      </generator>
    </id>
    <property name='Titulo'
              column='`Titulo`'
              />
    <property name='AutorId'
              column='`Autor`'
              />
    <property name='TituloOriginal'
              column='`TituloOriginal`'
              />
    <bag name='Resenhas'
          inverse='false'
          >
      <key column='`IdLibroId`' />
      <one-to-many class='Resenha' />
    </bag>
    <many-to-one name='Autor' class='Autor' column='`AutorId`' />
  </class>
</hibernate-mapping>");
        CustomizeMappingDocument(mappingDocument);
        return mappingDocument;
      }
    }
  }


}
