using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using NHibernate.Validator.Constraints;

namespace Libros
{

  /// <summary>
  /// Provides a NHibernate configuration object containing mappings for this model.
  /// </summary>
  public static class ConfigurationHelper
  {
    /// <summary>
    /// Creates a NHibernate configuration object containing mappings for this model.
    /// </summary>
    /// <returns>A NHibernate configuration object containing mappings for this model.</returns>
    public static Configuration CreateConfiguration()
    {
      var configuration = new Configuration();
      configuration.Configure();
      ApplyConfiguration(configuration);
      return configuration;
    }

    /// <summary>
    /// Adds mappings for this model to a NHibernate configuration object.
    /// </summary>
    /// <param name="configuration">A NHibernate configuration object to which to add mappings for this model.</param>
    public static void ApplyConfiguration(Configuration configuration)
    {
      configuration.AddXml(Libro.MappingXml.ToString());
      configuration.AddXml(Resenha.MappingXml.ToString());
      configuration.AddXml(Autor.MappingXml.ToString());
      configuration.AddAssembly(typeof(ConfigurationHelper).Assembly);
    }
  }
}
