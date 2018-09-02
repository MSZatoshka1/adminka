 SELECT  m.Id,
 m.id_organization,
 m.id_specialty,
 org.Id,
 org.name,
 cpes.Id,
 cpes.name,
 FROM `Man` m
 LEFT OUTER JOIN `organization` org ON org.Id = m.id_organization
 LEFT OUTER JOIN `specialty` cpes ON cpes.Id = m.id_specialty
-- LEFT OUTER JOIN `specialty` org ON cpes.Id = m.id_specialty

 