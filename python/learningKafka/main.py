import logging

from kafka import KafkaConsumer, KafkaProducer
from kafka.errors import KafkaError

# PRODUCER

# KAFKA_HOST = 'localhost:9092'
# consumer = KafkaConsumer(bootstrap_servers=KAFKA_HOST)
# print(consumer.topics())
#
# conf = {
#     'bootstrap.servers': 'localhost:9092'  # Endereço do servidor Kafk
# }
# num = 123
# producer = KafkaProducer('localhost:9092')
# producer.send('my_favorite_topic', value={
#     "name": "Evy Lina",
#     "hotel": "Cheap Hotel",
#     "dateFrom": "14-07-2024",
#     "dateTo": "01-08-2021",
#     "details": "Wish coffee ready 😀"
# })
#
# connection = KafkaProducer(bootstrap_servers=kafka_settings['bootstrap_servers'])
# future = connection.send(kafka_settings['topic'], b'your_message_here')

topic = 'my_favorite_topic'

producer = KafkaProducer(bootstrap_servers=['localhost:9092'])
future = producer.send(topic, b'raw_bytes')

try:
    record_metadata = future.get(timeout=10)
except KafkaError:
    logging.exception()
    pass

print(record_metadata.topic)
print(record_metadata.partition)
print(record_metadata.offset)

producer.send(topic, b'hi Ana :)', b'my-key')

try:
    record = future.get(timeout=10)
except KafkaError:
    logging.exception()
    pass

print("-------------------")
print(record.topic)
print(record.partition)
print(record.offset)

# CONSUMER

consumer = KafkaConsumer(
    topic,                                         # topic name
    bootstrap_servers=['localhost:9092'],          # Kafka server address
    auto_offset_reset='earliest',                  # start reading from the beggining if no offset is stored
    enable_auto_commit=True,                       # automatically update the offset to ensure the message is not read again
    group_id='meu-grupo-consumidor',               # consumer group ID
    value_deserializer=lambda x: x.decode('utf-8') # decodes the message value from bytes to string
)

for message in consumer:
    print(f"Topic: {message.topic}, Partition: {message.partition}, Offset: {message.offset}")
    print(f"Key: {message.key}, Value: {message.value}")